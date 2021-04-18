import { CommonModule } from '@angular/common';
import { NgModule } from '@angular/core';
import { TimeWhenPipe } from './time-when.pipe';

@NgModule({
    imports: [
        CommonModule
    ],
    declarations: [
        TimeWhenPipe
    ],
    exports: [
        TimeWhenPipe
    ]
})
export class ApplicationPipesModule { }
