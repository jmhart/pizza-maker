import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-pizza-form',
  templateUrl: './pizza-form.component.html',
  styleUrls: ['./pizza-form.component.css']
})
export class PizzaFormComponent implements OnInit {

  toppings = [
    'Pepperoni',
    'Beef',
    'Sausage',
    'Bacon',
    'Anchovies',
    'Mushrooms',
    'Tomatoes',
    'Pineapple',
    'Onions',
    'Black Olives',
    'Jalapeno peppers',
    'Green peppers'
  ]
  constructor() { }

  ngOnInit() {
  }

}
