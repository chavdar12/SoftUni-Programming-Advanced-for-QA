import { expect } from 'chai';
import { captureLog } from '../../../captureLog.js';
import { solve as cookingByNumbers } from '../12.CookingByNumbers.js';

describe('12.CookingByNumbers', () => {
    it('12 applies cooking operations in order', () => {
        expect(captureLog(() => cookingByNumbers('32', 'chop', 'chop', 'chop', 'chop', 'chop')))
            .to.deep.equal(['16', '8', '4', '2', '1']);
        expect(captureLog(() => cookingByNumbers('9', 'dice', 'spice', 'chop', 'bake', 'fillet')))
            .to.deep.equal(['3', '4', '2', '6', '4.8']);
    });
});
