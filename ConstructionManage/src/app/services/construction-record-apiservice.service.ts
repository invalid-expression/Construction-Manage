import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { ConstructionRecord } from '../features/construction-record/construction-record.model';

@Injectable({
  providedIn: 'root'
})
export class ConstructionRecordAPIServiceService {

  private apiURL = 'https://mocki.io/v1/abb3348f-3b80-419d-a496-03d7748cce3f';

  constructor(private http: HttpClient) {}

  getData(): Observable<ConstructionRecord> {
    return this.http.get<ConstructionRecord>(this.apiURL);
  }
}
