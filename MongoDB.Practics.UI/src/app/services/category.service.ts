import { Injectable } from '@angular/core';
import { HttpClient, HttpRequest, HttpEvent } from '@angular/common/http';
import { Observable } from 'rxjs';
import { ICategory } from '../models/Iorder-details';

@Injectable({
  providedIn: 'root'
})
export class CategoryService {
  private baseUrl = 'https://localhost:7006/OrderDetailsAPI/v1/OrderDetails';

  constructor(private http: HttpClient) { }

  getCategorys(): Observable<ICategory[]> { 
    return this.http.get<ICategory[]>(this.baseUrl)
  }

 
}
