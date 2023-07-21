import { Component, OnInit } from "@angular/core";
import { CategoryService } from '../services/category.service';
import { CategoryModel } from "../models/categoryModel";

@Component({
    selector: 'categories-container',
    templateUrl: 'categories.container.html'
})

export class CategoriesContainer implements OnInit{

    constructor(private categoryService: CategoryService){}

    categories: CategoryModel[] = [];

    ngOnInit(): void {
        this.categoryService.GetAllCategories().subscribe(x => this.categories = x);
    }
}