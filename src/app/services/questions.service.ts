import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Observable } from "rxjs";
import { QuestionModel } from "../models/questionModel";

@Injectable()
export class QuestionsService{
    private readonly questionUrl = 'https://localhost:5056/api/question';

    constructor(protected http: HttpClient){}

    public GetQuestionsByCategoryName() : Observable<QuestionModel[]>{
        return this.http.get<QuestionModel[]>(`${this.questionUrl}/category`);
    }
}