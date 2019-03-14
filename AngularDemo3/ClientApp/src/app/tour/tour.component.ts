import { Component, OnInit, Input } from '@angular/core';

@Component({
  selector: 'app-tour',
  templateUrl: './tour.component.html',
  styleUrls: ['./tour.component.css']
})
export class TourComponent implements OnInit {

  @Input() destinationList: string[];

  constructor() { }

  ngOnInit() {
  }

}
