 import { Injectable } from '@angular/core';

import { Product } from "./Product";
import { loggerService } from './loggerservice.service';

@Injectable({
  providedIn: 'root'
})
export class ProductServiceService {

  constructor(private loggerservice:loggerService){
    this.loggerservice.log("product service constructed");
  }

 
  public getProducts() {

    this.loggerservice.log("getProducts called");

    let products: Product[];

    products = [
        new Product(11, 'Memory Card', 500),
        new Product(12, 'Pen Drive', 750),
        new Product(13, 'Memory Card', 300),
        new Product(14, 'Pen Drive', 650),
        new Product(15, 'Memory Card', 5050),
        new Product(16, 'Pen Drive', 1750),
        new Product(17, 'Power Bank', 6100)
    ]

    this.loggerservice.log(products);

    return products;
}
}
