import { Component, ViewChild } from '@angular/core';
import { ProductService } from '../services/product-service/product.service.service';
import { Product } from '../models/product';
import { Column } from '../models/column';

@Component({
  selector: 'app-reporting-grid',
  templateUrl: './reporting-grid.component.html',
  styleUrl: './reporting-grid.component.scss',
})
export class ReportingGridComponent {
  @ViewChild('dt') dataTable: any;

  products!: Product[];
  columns!: Column[];
  _selectedColumns!: Column[];

  columnWidths: { [key: string]: number } = {};

  constructor(private readonly productService: ProductService) {}

  ngOnInit() {
    this.productService.getProductsMini().then((data) => {
      this.products = data;
    });

    this.columns = [
      { field: 'code', header: 'Code' },
      { field: 'name', header: 'Name' },
      { field: 'category', header: 'Category' },
      { field: 'quantity', header: 'Quantity' },
    ];
    this.selectedColumns = this.columns;
  }

  ngAfterViewInit(): void {
    //Called after ngAfterContentInit when the component's view has been initialized. Applies to components only.
    //Add 'implements AfterViewInit' to the class.
    this.loadColumnWidths();
  }

  get selectedColumns(): Column[] {
    return this._selectedColumns;
  }

  set selectedColumns(val: Column[]) {
    //restore original order
    this._selectedColumns = this.columns.filter((col) => val.includes(col));
  }

  loadColumnWidths() {
    const savedWidth = JSON.parse(localStorage.getItem('columnWidths') ?? '{}');
    if (savedWidth) {
      this.columnWidths = savedWidth;
    }
  }

  saveColumnWidths() {
    const columns = this.dataTable.el.nativeElement.querySelectorAll('th');
    columns.forEach((element: HTMLElement, index: number) => {
      const field = columns[index].id;// Get the field name
      this.columnWidths[field] = element.clientWidth; // Save the width
    });
    localStorage.setItem('columnWidths', JSON.stringify(this.columnWidths));
  }
}
