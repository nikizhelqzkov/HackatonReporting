import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ReportingGridComponent } from './reporting-grid.component';

describe('ReportingGridComponent', () => {
  let component: ReportingGridComponent;
  let fixture: ComponentFixture<ReportingGridComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [ReportingGridComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(ReportingGridComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
