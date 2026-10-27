import { expect } from 'chai';
import { captureLog } from '../../../captureLog.js';
import { solve as storeProvision } from '../13.StoreProvision.js';

describe('13.StoreProvision', () => {
    it('13 merges current and ordered stock', () => {
        expect(captureLog(() => storeProvision(
            ['Chips', '5', 'CocaCola', '9', 'Bananas', '14', 'Pasta', '4', 'Beer', '2'],
            ['Flour', '44', 'Oil', '12', 'Pasta', '7', 'Tomatoes', '70', 'Bananas', '30']
        ))).to.deep.equal([
            'Chips -> 5', 'CocaCola -> 9', 'Bananas -> 44', 'Pasta -> 11', 'Beer -> 2',
            'Flour -> 44', 'Oil -> 12', 'Tomatoes -> 70'
        ]);
    });
});
