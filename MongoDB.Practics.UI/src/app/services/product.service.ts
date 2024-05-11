import { Injectable } from '@angular/core';
import { HttpClient, HttpRequest, HttpEvent } from '@angular/common/http';
import { Observable } from 'rxjs';
import { ICategory, IProducts } from '../models/Iorder-details';

@Injectable({
  providedIn: 'root'
})
export class ProductService {
  private baseUrl = 'https://localhost:7006/ProductsAPI/v1/Products';

  constructor(private http: HttpClient) { }

  getProducts(): Observable<IProducts[]> { 
    return this.http.get<IProducts[]>(this.baseUrl)
  }

 
}
