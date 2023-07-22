import { Component, OnInit } from "@angular/core";
import { QuestionsService } from '../../services/questions.service'
import { QuestionModel } from "src/app/models/questionModel";
import { ActivatedRoute } from "@angular/router";

@Component({
    selector: 'questions-container',
    templateUrl: 'questions.container.html'
})

export class QuestionsContainer implements OnInit{

    constructor(
        private questionsService: QuestionsService,
        private route: ActivatedRoute){}

    questions: QuestionModel[] = [];

    ngOnInit(): void {
        let category = this.route.snapshot.paramMap.get('category')!;
        this.questionsService.GetQuestionsByCategoryName(category).subscribe(x => this.questions = x);
    }
}