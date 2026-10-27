import { expect } from 'chai';
import { captureLog } from '../../../captureLog.js';
import { solve as orders } from '../10.Orders.js';

describe('10.Orders', () => {
    it('10 prices orders and rejects unknown products', () => {
        expect(captureLog(() => orders('water', 5))).to.deep.equal(['5.00']);
        expect(captureLog(() => orders('coffee', 2))).to.deep.equal(['3.00']);
        expect(captureLog(() => orders('tea', 1))).to.deep.equal(['Error!']);
    });
});
