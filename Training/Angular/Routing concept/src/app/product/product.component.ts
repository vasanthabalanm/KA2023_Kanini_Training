import { Component } from '@angular/core';
import { Product } from './Product';
import { ProductService } from './product-service.service';

@Component({
  selector: 'app-product',
  templateUrl: './product.component.html',
  styleUrls: ['./product.component.css']
})
export class ProductComponent {
  products!: Product[];
   
  constructor(private productService:ProductService){
  }

  ngOnInit() {
    this.products=this.productService.getProducts();
  }

}
