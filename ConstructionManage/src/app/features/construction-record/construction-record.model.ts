export interface ConstructionRecordProperty {
  Label: string;
  Value: any; // string | number | boolean is okay too
}

export interface ConstructionRecordData {
  SamplingTime: string;
  Properties: ConstructionRecordProperty[];
}

export interface ConstructionRecord {
  Id: number;
  Name: string;
  Datas: ConstructionRecordData[]; 
}
