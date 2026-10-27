import { expect } from 'chai';
import { captureLog } from '../../../captureLog.js';
import { solve as mathPower } from '../08.MathPower.js';

describe('08.MathPower', () => {
    it('08 raises a number to a power', () => {
        expect(captureLog(() => mathPower(2, 8))).to.deep.equal(['256']);
    });
});
