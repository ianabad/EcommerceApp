import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { IProduct } from './models/product';
import { IProductList } from './models/productlist';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent implements OnInit {
  title = 'Ecommerce';
  products: IProduct[];

  constructor(private http: HttpClient) { };

  ngOnInit(): void {
    this.http.get('https://localhost:5001/api/products').subscribe(
    (response: IProductList) => {
      this.products = response.data;
    }, error => {
      console.log(error);
    });
  }
}
