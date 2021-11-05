import { GraceToolsTemplatePage } from './app.po';

describe('GraceTools App', function() {
  let page: GraceToolsTemplatePage;

  beforeEach(() => {
    page = new GraceToolsTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
