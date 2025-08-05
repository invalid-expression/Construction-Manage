import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AddConstructionComponent } from './add-construction.component';

describe('AddConstructionComponent', () => {
  let component: AddConstructionComponent;
  let fixture: ComponentFixture<AddConstructionComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [AddConstructionComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(AddConstructionComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
