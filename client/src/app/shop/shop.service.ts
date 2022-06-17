import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { IProductList } from '../shared/models/productlist';

@Injectable({
  providedIn: 'root'
})

export class ShopService {
  baseUrl = 'https://localhost:5001/api/';

  constructor(private http: HttpClient) { };

  getProducts() {
    return this.http.get<IProductList>(this.baseUrl + 'products');
  }
}
