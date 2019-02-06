import { PizzaService } from './../services/pizza.service';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-pizza',
  templateUrl: './pizza.component.html',
  styleUrls: ['./pizza.component.css']
})
export class PizzaComponent implements OnInit {
  pizzas = []

  constructor(private pizzaService: PizzaService) { }

  ngOnInit() {
    this.pizzaService.getAll().subscribe(p => {
      this.pizzas = p;
      console.log(this.pizzas);
    })
  }

}
