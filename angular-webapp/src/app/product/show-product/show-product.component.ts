import { Component, OnInit } from '@angular/core';
import { Observable } from 'rxjs';
import { ProductApiService } from 'src/app/product-api.service';

@Component({
  selector: 'app-show-product',
  templateUrl: './show-product.component.html',
  styleUrls: ['./show-product.component.css']
})
export class ShowProductComponent implements OnInit {

  custId:any;
  productList$!:Observable<any[]>;
  ProductList:any=[];
  currentContactInfo: any = {};

  constructor(private service:ProductApiService) { }

  ngOnInit(): void {
      this.productList$ = this.service.getProductList();
  }

  productInfo(id:any){
    this.service.getProductId(id).subscribe(res => {
      this.currentContactInfo = res;
  });
  }
}
