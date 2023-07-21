import { Component, Input } from "@angular/core";
import { CategoryModel } from "../models/categoryModel";

@Component({
    selector: 'category-component',
    templateUrl: 'category.component.html'
})
export class CategoryComponent{

    @Input() categories: CategoryModel[] = [];
}