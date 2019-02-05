import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class ToppingService {

  constructor() { }

  toppings = [
    {
      "id": 1,
      "name": "Olives",
      "category": "Vegetable"
    },
    {
      "id": 2,
      "name": "Onions",
      "category": "Vegetable"
    },
    {
      "id": 3,
      "name": "Pepperoni",
      "category": "Meat"
    },
    {
      "id": 4,
      "name": "Pineapple",
      "category": "Vegetable"
    },
    {
      "id": 5,
      "name": "Green Peppers",
      "category": "Vegetable"
    },
  ]
  getToppings() {
    return this.toppings;
  }
}
