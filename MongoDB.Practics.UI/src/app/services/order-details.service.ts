import { Injectable } from '@angular/core';
import { HttpClient, HttpRequest, HttpEvent } from '@angular/common/http';
import { Observable } from 'rxjs';
import { IOrderDetails } from '../models/Iorder-details';

@Injectable({
  providedIn: 'root'
})
export class OrderDetailsService {
  private baseUrl = 'https://localhost:7006/OrderDetailsAPI/v1/OrderDetails';

  constructor(private http: HttpClient) { }

  getOrderDetails(): Observable<IOrderDetails[]> { 
    return this.http.get<IOrderDetails[]>(this.baseUrl)
  }

 
}
