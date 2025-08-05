import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ConstructionRecordComponent } from './construction-record.component';

describe('ConstructionRecordComponent', () => {
  let component: ConstructionRecordComponent;
  let fixture: ComponentFixture<ConstructionRecordComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [ConstructionRecordComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(ConstructionRecordComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
