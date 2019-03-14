import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-tour-plan',
  templateUrl: './tour-plan.component.html',
  styleUrls: ['./tour-plan.component.css']
})
export class TourPlanComponent implements OnInit {

  public searchText: string;

  public searchResults: string[];

  public destinationList: string[];

  constructor() {
    this.searchResults = ["Matara", "Galle", "Colombo", "Matale", "Gampaha"];
    this.destinationList = [];
  }

  ngOnInit() {
  }

  clickMe(destination: string) {
    this.destinationList.push(destination);
    console.log(this.destinationList);
  }

}
