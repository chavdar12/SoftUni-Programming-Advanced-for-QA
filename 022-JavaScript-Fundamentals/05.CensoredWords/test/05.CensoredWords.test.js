import { expect } from 'chai';
import { captureLog } from '../../../captureLog.js';
import { solve as censoredWords } from '../05.CensoredWords.js';

describe('05.CensoredWords', () => {
    it('05 censors every occurrence of the banned word', () => {
        expect(captureLog(() => censoredWords('Find the hidden word in the hidden text', 'hidden')))
            .to.deep.equal(['Find the ****** word in the ****** text']);
    });
});
