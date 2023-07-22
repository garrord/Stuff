import { Component, EventEmitter, Input, Output } from "@angular/core";
import { CategoryModel } from "../../models/categoryModel";

@Component({
    selector: 'category-component',
    templateUrl: 'category.component.html',
    styleUrls: ['category.component.scss']
})
export class CategoryComponent{

    @Input() categories: CategoryModel[] = [];
    @Output() category: EventEmitter<string> = new EventEmitter<string>();

    toQuestions(category: string){
        this.category.emit(category);
    }
}