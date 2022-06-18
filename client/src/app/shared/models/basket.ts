import { v4 as uuidv4 } from 'uuid';

export interface IBasketItem {
    id: number;
    productName: string;
    price: number;
    quantity: number;
}

export interface IBasket {
    id: string;
    items: IBasketItem[];
}

export class Basket implements IBasket {
    id = uuidv4(); 
    items: IBasketItem[] = [];
}

export interface IBasketTotals {
    tax: number;
    subtotal: number;
    total: number;
}