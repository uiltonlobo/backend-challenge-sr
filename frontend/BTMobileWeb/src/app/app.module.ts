import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppComponent } from './app.component';
import { ListarComponent } from './ficha/listar/listar.component';
import { EditarComponent } from './ficha/editar/editar.component';

import { RouterModule, Routes } from '@angular/router';
import { FichaService } from './ficha.service';
import { HttpClientModule } from '@angular/common/http';
import { AlterarCargaComponent } from './ficha/alterar-carga/alterar-carga.component';

const appRoutes: Routes = [
  //{ path: 'ficha', component: ListarComponent }
  { path: '', component: ListarComponent },
  { path: 'ficha/:id', component: EditarComponent},
  { path: 'exercicioSerie', component: AlterarCargaComponent}
]

@NgModule({
  declarations: [
    AppComponent,
    ListarComponent,
    EditarComponent,
    AlterarCargaComponent
  ],
  imports: [
    BrowserModule,
    RouterModule.forRoot(appRoutes),
    HttpClientModule
  ],
  providers: [
    FichaService
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
