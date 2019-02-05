import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { httpFactory } from '@angular/platform-server/src/http';

@Injectable({
  providedIn: 'root'
})
export class PizzaService {

  constructor(private http: HttpClient) { }

  url = "/api/pizza"

  post(pizza) {
    return this.http.post(this.url, pizza);
  }
}
