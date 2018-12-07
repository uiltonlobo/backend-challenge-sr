import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { AlterarCargaComponent } from './alterar-carga.component';

describe('AlterarCargaComponent', () => {
  let component: AlterarCargaComponent;
  let fixture: ComponentFixture<AlterarCargaComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ AlterarCargaComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(AlterarCargaComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
