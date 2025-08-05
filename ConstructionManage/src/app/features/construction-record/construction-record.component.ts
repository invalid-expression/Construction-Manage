import { Component, OnInit } from '@angular/core';
import { bootstrapApplication } from '@angular/platform-browser';
import { AppComponent } from '../../app.component';
import { HttpClient, provideHttpClient } from '@angular/common/http';
import { ConstructionRecordAPIServiceService } from '../../services/construction-record-apiservice.service';
import { CommonModule } from '@angular/common';
import { ConstructionRecord } from './construction-record.model';

bootstrapApplication(AppComponent, {
  providers: [provideHttpClient()]
});

@Component({
  selector: 'app-construction-record',
  imports: [CommonModule],
  standalone: true,
  templateUrl: './construction-record.component.html',
  styleUrl: './construction-record.component.css'
})
export class ConstructionRecordComponent implements OnInit{

  observationData: ConstructionRecord | null = null ;

  constructor(private observationService: ConstructionRecordAPIServiceService) {}

  getProperty(record: any, label: string): any {
  const found = record.Properties.find((p: any) => p.Label === label);
  return found ? found.Value : '';
}

  ngOnInit(): void {
    this.observationService.getData().subscribe(data => {
      this.observationData = data;
    });
  }
}



  // constructor(private contructorAPIService: ConstructionRecordAPIServiceService) {}

  // ngOnInit(){
  //   this.FetchData();
  // }

  // FetchData(){
  //   this.contructorAPIService.getData().subscribe({
  //     next: data => {
  //       this.constructionRecord = data;
  //       console.log('Data:', data);
  //     },
  //     error: err => {
  //       console.error('Error: ', err);
  //     },
  //     complete: () => {
  //       console.log('Complete..');
  //     }
  //   });
  // }
// }
