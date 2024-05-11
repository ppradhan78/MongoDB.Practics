import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { MenuComponent } from './components/menu/menu.component';
import { OrderDetailsComponent } from './components/order-details/order-details.component';
import { HomeComponent } from './components/home/home.component';
import { CategoryComponent } from './components/category/category.component';
import { CustomerComponent } from './components/customer/customer.component';
import { OrdersComponent } from './components/orders/orders.component';
import { ProductComponent } from './components/product/product.component';
import { ShipperComponent } from './components/shipper/shipper.component';
import { SupplierComponent } from './components/supplier/supplier.component';
import { EmployeesComponent } from './components/employees/employees.component';


@Component({
  selector: 'app-root',
  standalone: true,
  imports: [RouterOutlet, MenuComponent, OrderDetailsComponent, HomeComponent,
    CategoryComponent, CustomerComponent,EmployeesComponent, OrdersComponent,
    ProductComponent, ShipperComponent, SupplierComponent],
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent {
  title = 'MongoDB.Practics.UI';
}
