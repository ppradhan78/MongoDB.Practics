
export interface IOrderDetails {
  id: string;
  orderID: string;
  productID: string;
  unitPrice: string;
  quantity: string;
}

export interface ICategory {
  CategoryID: number;
  CategoryName: string;
  Description: string;
}
export interface IProducts {
  productID: number;
  productName: string;
  supplierID: number;
  categoryID: number;
  quantityPerUnit: string;
  unitPrice: string;
  unitsInStock: number;
  unitsOnOrder: number;
  reorderLevel: number;
  discontinued: string;
  
}


