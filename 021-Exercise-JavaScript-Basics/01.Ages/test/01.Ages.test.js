import { expect } from 'chai';
import { captureLog } from '../../../captureLog.js';
import { solve as ages } from '../01.Ages.js';

describe('01.Ages', () => {
    it('01 classifies ages', () => {
        expect(captureLog(() => ages(1))).to.deep.equal(['baby']);
        expect(captureLog(() => ages(20))).to.deep.equal(['adult']);
        expect(captureLog(() => ages(100))).to.deep.equal(['elder']);
        expect(captureLog(() => ages(-1))).to.deep.equal(['out of bounds']);
    });
});
