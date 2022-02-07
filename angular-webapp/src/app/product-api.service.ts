import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class ProductApiService {

  readonly productAPIUrl = "https://localhost:7250/api";

  constructor(private http:HttpClient) { }

  //ProductAPI
  getProductList():Observable<any[]> {
    return this.http.get<any>(this.productAPIUrl + '/Products');
  }

  getProductId(id:number|string){
    return this.http.get<any>(this.productAPIUrl + `/Products/${id}`);
  }

  addProduct(data:any) {
    return this.http.get<any>(this.productAPIUrl + '/Products', data);
  }

  updateProduct(id:number|string ,data:any) {
    return this.http.get<any>(this.productAPIUrl + `/Products/${id}`, data);
  }

  deleteProduct(id:number|string) {
    return this.http.get<any>(this.productAPIUrl + `/Products/${id}`);
  }
  
}
