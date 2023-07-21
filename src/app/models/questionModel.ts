import { AnswerModel } from './answerModel';

export class QuestionModel{
    questionId!: number;
    conundrum!: string;
    answers!: AnswerModel[];
}