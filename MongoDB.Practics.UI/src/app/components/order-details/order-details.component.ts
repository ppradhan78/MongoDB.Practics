import { MatTableDataSource, MatTableModule } from '@angular/material/table';
import { AfterViewInit, Component, NgModule, OnInit, ViewChild } from '@angular/core';
import { MatSort } from '@angular/material/sort';
import { MatPaginator, MatPaginatorModule } from '@angular/material/paginator';
import { OrderDetailsService } from '../../services/order-details.service';
import { IOrderDetails } from '../../models/Iorder-details';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-order-details',
  standalone: true,
  imports: [MatTableModule, MatPaginatorModule, CommonModule],
  templateUrl: './order-details.component.html',
  styleUrl: './order-details.component.css'
})
export class OrderDetailsComponent implements OnInit {

  displayedColumns: string[] = ['orderID', 'productID', 'unitPrice', 'quantity'];
  OrderDetails: IOrderDetails[] = [];
  searchText: any;
  dataSource = new MatTableDataSource<IOrderDetails>(this.OrderDetails)
  @ViewChild(MatSort) private sort!: MatSort;
  @ViewChild(MatPaginator) private paginator!: MatPaginator;

  constructor(private orderDetailsService: OrderDetailsService) {
  }

  ngOnInit() {
    this.getOrderDetails();
  }

  getOrderDetails() {
    this.orderDetailsService.getOrderDetails().subscribe(responce => {
      this.OrderDetails = responce;
      this.dataSource = new MatTableDataSource(responce);
      this.dataSource.paginator = this.paginator;
      this.dataSource.sort = this.sort;
    })
  }
  filter($event: any): void {
    this.dataSource.filter =$event.target.value.trim().toLowerCase();
  }

  
}


