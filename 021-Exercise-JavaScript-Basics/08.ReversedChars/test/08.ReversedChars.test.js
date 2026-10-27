import { expect } from 'chai';
import { captureLog } from '../../../captureLog.js';
import { solve as reversedChars } from '../08.ReversedChars.js';

describe('08.ReversedChars', () => {
    it('08 reverses three chars', () => {
        expect(captureLog(() => reversedChars('A', 'B', 'C'))).to.deep.equal(['C B A']);
    });
});
