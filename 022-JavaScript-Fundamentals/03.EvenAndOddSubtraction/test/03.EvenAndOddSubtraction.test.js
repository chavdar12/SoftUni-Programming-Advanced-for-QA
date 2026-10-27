import { expect } from 'chai';
import { captureLog } from '../../../captureLog.js';
import { solve as evenAndOdd } from '../03.EvenAndOddSubtraction.js';

describe('03.EvenAndOddSubtraction', () => {
    it('03 subtracts the odd sum from the even sum', () => {
        expect(captureLog(() => evenAndOdd([1, 2, 3, 4, 5, 6]))).to.deep.equal(['3']);
    });
});
