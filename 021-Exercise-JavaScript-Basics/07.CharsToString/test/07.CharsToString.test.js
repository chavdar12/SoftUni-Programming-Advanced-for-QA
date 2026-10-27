import { expect } from 'chai';
import { captureLog } from '../../../captureLog.js';
import { solve as charsToString } from '../07.CharsToString.js';

describe('07.CharsToString', () => {
    it('07 joins three chars', () => {
        expect(captureLog(() => charsToString('a', 'b', 'c'))).to.deep.equal(['abc']);
    });
});
