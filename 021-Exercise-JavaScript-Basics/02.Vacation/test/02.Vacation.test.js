import { expect } from 'chai';
import { captureLog } from '../../../captureLog.js';
import { solve as vacation } from '../02.Vacation.js';

describe('02.Vacation', () => {
    it('02 applies group discounts', () => {
        expect(captureLog(() => vacation(30, 'Students', 'Sunday'))).to.deep.equal(['Total price: 266.73']);
        expect(captureLog(() => vacation(40, 'Regular', 'Saturday'))).to.deep.equal(['Total price: 800.00']);
    });
});
