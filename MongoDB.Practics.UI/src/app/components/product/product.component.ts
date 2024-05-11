import { IProducts } from '../../models/Iorder-details';
import { MatTableDataSource, MatTableModule } from '@angular/material/table';
import { AfterViewInit, Component, NgModule, OnInit, ViewChild } from '@angular/core';
import { MatSort } from '@angular/material/sort';
import { MatPaginator, MatPaginatorModule } from '@angular/material/paginator';
import { ProductService } from '../../services/product.service';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-product',
  standalone: true,
  imports: [MatTableModule, MatPaginatorModule, CommonModule],
  templateUrl: './product.component.html',
  styleUrl: './product.component.css'
})
export class ProductComponent {
  displayedColumns: string[] = ['productID', 'productName', 'supplierID', 'categoryID', 'quantityPerUnit',
    'unitPrice', 'unitsInStock', 'unitsOnOrder', 'reorderLevel','discontinued'
  ];
  ProductDetails: IProducts[] = [];
  searchText: any;
  dataSource = new MatTableDataSource<IProducts>(this.ProductDetails)
  @ViewChild(MatSort) private sort!: MatSort;
  @ViewChild(MatPaginator) private paginator!: MatPaginator;

  constructor(private productService: ProductService) {
  }

  ngOnInit() {
    this.getProductDetails();
  }

  getProductDetails() {
    this.productService.getProducts().subscribe(responce => {
      this.ProductDetails = responce;
      this.dataSource = new MatTableDataSource(responce);
      this.dataSource.paginator = this.paginator;
      this.dataSource.sort = this.sort;
    })
  }
  filter($event: any): void {
    this.dataSource.filter = $event.target.value.trim().toLowerCase();
  }
}
