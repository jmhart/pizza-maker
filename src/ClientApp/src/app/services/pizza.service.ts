import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { httpFactory } from '@angular/platform-server/src/http';
import { getAllDebugNodes } from '@angular/core/src/debug/debug_node';
import { Pizza } from '../pizza';

@Injectable({
  providedIn: 'root'
})
export class PizzaService {

  constructor(private http: HttpClient) { }

  url = "/api/pizza"

  getAll() {
    return this.http.get<any[]>(this.url);
  }
  post(pizza) {
    return this.http.post(this.url, pizza);
  }
}
