import { PizzaService } from './../services/pizza.service';
import { ToppingService } from './../services/topping.service';
import { Component, OnInit } from '@angular/core';
import * as _ from 'lodash';

@Component({
  selector: 'app-pizza-form',
  templateUrl: './pizza-form.component.html',
  styleUrls: ['./pizza-form.component.css']
})
export class PizzaFormComponent implements OnInit {

  toppings = []

  pizza = {
    id: 0,
    size: '',
    crust: '',
    cheese: '',
    sauce: '',
    toppings: []
  }

  constructor(private toppingService: ToppingService
    , private pizzaService: PizzaService) {
    this.toppings = toppingService.getToppings();
    this.toppings.map(x => x.checked = false);
    console.log(this.toppings);
  }

  ngOnInit() {
  }

  toggleTopping() {
    let toppings = this.toppings.filter(x => x.checked);
    this.pizza.toppings = toppings;
    console.log(this.pizza.toppings);
  }

  submit() {
    this.pizzaService.post(this.pizza).subscribe(x => {
      console.log(x);
      alert("Pizza created!");
    }, error => {
      console.log(error);
      alert("Error");
    });
  }
}
