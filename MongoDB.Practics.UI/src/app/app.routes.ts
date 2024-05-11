import { Routes } from '@angular/router';
import { OrderDetailsComponent } from './components/order-details/order-details.component';
import { HomeComponent } from './components/home/home.component';
import { CategoryComponent } from './components/category/category.component';
import { CustomerComponent } from './components/customer/customer.component';
import { OrdersComponent } from './components/orders/orders.component';
import { ProductComponent } from './components/product/product.component';
import { ShipperComponent } from './components/shipper/shipper.component';
import { SupplierComponent } from './components/supplier/supplier.component';
import { EmployeesComponent } from './components/employees/employees.component';

export const routes: Routes = [
  { path: '', redirectTo: '/OrderDetails', pathMatch: 'full' },
  { path: 'home', component: HomeComponent },
  { path: 'OrderDetails', component: OrderDetailsComponent },
  { path: 'category', component: CategoryComponent },
  { path: 'customer', component: CustomerComponent },
  { path: 'employees', component: EmployeesComponent },
  { path: 'orders', component: OrdersComponent },
  { path: 'product', component: ProductComponent },
  { path: 'shipper', component: ShipperComponent },
  { path: 'supplier', component: SupplierComponent },
 /* { path: '**', component: HomeComponent }*/

];
