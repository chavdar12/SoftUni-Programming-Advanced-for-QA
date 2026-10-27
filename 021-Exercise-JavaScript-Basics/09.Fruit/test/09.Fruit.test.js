import { expect } from 'chai';
import { captureLog } from '../../../captureLog.js';
import { solve as fruit } from '../09.Fruit.js';

describe('09.Fruit', () => {
    it('09 prices fruit by weight', () => {
        expect(captureLog(() => fruit('orange', 2500, 1.80)))
            .to.deep.equal(['I need $4.50 to buy 2.50 kilograms orange.']);
    });
});
