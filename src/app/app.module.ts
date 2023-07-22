import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { AppComponent } from './app.component';
import { HttpClientModule } from '@angular/common/http';
import { CategoryService } from './services/category.service';
import { QuestionsService } from './services/questions.service'; 
import { RouterModule } from '@angular/router';
import { WelcomeComponent } from './components/welcome/welcome.component';
import { PageNotFoundComponent } from './components/pageNotFound/pageNotFound.component';
import { CategoriesContainer } from './containers/categories/categories.container';
import { CategoryComponent } from './components/categories/category.component';
import { MatButtonModule } from '@angular/material/button';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';

@NgModule({
  declarations: [
    AppComponent,
    WelcomeComponent,
    PageNotFoundComponent,
    CategoryComponent,
    CategoriesContainer
  ],
  imports: [
    MatButtonModule,
    BrowserModule,
    HttpClientModule,
    RouterModule.forRoot([
      {
        path: 'welcome', component: WelcomeComponent
      },
      {
        path:'categories', component: CategoriesContainer
      },
      {
        path:'', redirectTo: 'welcome', pathMatch: 'full'
      },
      {
        path:'**', component: PageNotFoundComponent
      },
    ])
    //BrowserAnimationsModule,
  ],
  providers: [
    CategoryService,
    QuestionsService
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
