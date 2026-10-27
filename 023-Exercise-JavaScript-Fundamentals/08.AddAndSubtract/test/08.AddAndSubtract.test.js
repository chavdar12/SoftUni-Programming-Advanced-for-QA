import { expect } from 'chai';
import { captureLog } from '../../../captureLog.js';
import { solve as addAndSubtract } from '../08.AddAndSubtract.js';

describe('08.AddAndSubtract', () => {
    it('08 adds the first two and subtracts the third', () => {
        expect(captureLog(() => addAndSubtract(23, 6, 10))).to.deep.equal(['19']);
    });
});
