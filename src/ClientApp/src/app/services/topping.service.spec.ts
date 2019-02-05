import { TestBed, inject } from '@angular/core/testing';

import { ToppingService } from './topping.service';

describe('ToppingService', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [ToppingService]
    });
  });

  it('should be created', inject([ToppingService], (service: ToppingService) => {
    expect(service).toBeTruthy();
  }));
});
