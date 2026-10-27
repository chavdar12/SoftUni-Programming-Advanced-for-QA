import { expect } from 'chai';
import { captureLog } from '../../../captureLog.js';
import { solve as substring } from '../04.Substring.js';

describe('04.Substring', () => {
    it('04 extracts a substring by start and count', () => {
        expect(captureLog(() => substring('ASentence', 1, 8))).to.deep.equal(['Sentence']);
    });
});
