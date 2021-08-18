import { ComponentFixture, TestBed } from '@angular/core/testing';

import { RoleItemListComponent } from './role-item-list.component';

describe('RoleItemListComponent', () => {
  let component: RoleItemListComponent;
  let fixture: ComponentFixture<RoleItemListComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ RoleItemListComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(RoleItemListComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
