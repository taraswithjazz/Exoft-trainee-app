import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
  name: 'timeWhen'
})
export class TimeWhenPipe implements PipeTransform {
  transform(value: Date): string {
    const whenGiven = Math.abs(new Date().getTime() - new Date(value).getTime());
    const whenGivenMins = whenGiven / 1000 / 60;

    if (whenGivenMins >= 60 && whenGivenMins < 1440) {
      return `${Math.round(whenGivenMins / 60)} hours ago`;
    } else if (whenGivenMins >= 1440 && whenGivenMins <= 2880) {
      return 'Yesterday';
    } else if (whenGivenMins >= 2880) {
      return `${Math.round(whenGivenMins / 60 / 24)} days ago`;
    } else {
      return `${whenGivenMins.toFixed(0)} mins ago`;
    }
  }
}
