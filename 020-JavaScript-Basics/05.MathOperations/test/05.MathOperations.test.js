import { expect } from 'chai';
import { captureLog } from '../../../captureLog.js';
import { solve as mathOperations } from '../05.MathOperations.js';

describe('05.MathOperations', () => {
    it('05 performs the given math operation', () => {
        expect(captureLog(() => mathOperations(5, 6, '+'))).to.deep.equal(['11']);
        expect(captureLog(() => mathOperations(3, 5.5, '*'))).to.deep.equal(['16.5']);
        expect(captureLog(() => mathOperations(2, 3, '**'))).to.deep.equal(['8']);
    });
});
