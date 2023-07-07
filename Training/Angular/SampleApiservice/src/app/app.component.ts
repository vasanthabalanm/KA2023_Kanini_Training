import { Component } from '@angular/core';
import { ProductServiceService } from './product-service.service';
import { Product } from './Product';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'sampleApiService';
  products!: Product[];
  // productService;

  // constructor(){
  //   this.productService=new ProductService();
  // }

  constructor(private productService:ProductServiceService) {    
 
  }    

  getProductsfromService() {
    
    this.products=this.productService.getProducts();
  }
}
