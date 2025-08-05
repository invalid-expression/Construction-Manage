import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { AddConstructionComponent } from "./features/add-construction/add-construction.component";
import { ConstructionRecordComponent } from "./features/construction-record/construction-record.component";
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-root',
  imports: [AddConstructionComponent, ConstructionRecordComponent, CommonModule],
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent {
  title = 'ConstructionManage';
  SelectedSection = 2;

  ShowSection(){
    if (this.SelectedSection == 1) {
        this.SelectedSection = 1;
    } else {
      this.SelectedSection = 2;
    }
  }
}