using DragonStore.Catalogo.Application.Services;
using DragonStore.Catalogo.Application.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace DragonStore.WebApps.MVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProdutosController : Controller
    {
        private readonly IProdutoAppService _produtoAppService;

        public ProdutosController(IProdutoAppService produtoAppService)
        {
            _produtoAppService = produtoAppService;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            return View(await _produtoAppService.ObterTodos());
        }

        [HttpGet]
        public async Task<IActionResult> NovoProduto()
        {
            return View(await PopularCategorias(new ProdutoViewModel()));
        }

        [HttpPost]
        public async Task<IActionResult> NovoProduto(ProdutoViewModel produtoViewModel)
        {

            string messages = string.Join("; ", ModelState.Values
                                             .SelectMany(x => x.Errors)
                                             .Select(x => x.ErrorMessage));

            if (!ModelState.IsValid) 
                return View(await PopularCategorias(produtoViewModel));

            await _produtoAppService.AdicionarProduto(produtoViewModel);

            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> AtualizarProduto(Guid id)
        {
            return View(await PopularCategorias(await _produtoAppService.ObterPorId(id)));
        }

        [HttpPost]
        public async Task<IActionResult> AtualizarProduto(Guid id, ProdutoViewModel produtoViewModel)
        {
            var produto = await _produtoAppService.ObterPorId(id);
            produtoViewModel.QuantidadeEstoque = produto.QuantidadeEstoque;

            ModelState.Remove("QuantidadeEstoque");
            if (!ModelState.IsValid) return View(await PopularCategorias(produtoViewModel));

            await _produtoAppService.AtualizarProduto(produtoViewModel);

            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> AtualizarEstoque(Guid id)
        {
            return View("Estoque", await _produtoAppService.ObterPorId(id));
        }

        [HttpPost]
        public async Task<IActionResult> AtualizarEstoque(Guid id, int quantidade)
        {
            if (quantidade > 0)
            {
                await _produtoAppService.ReporEstoque(id, quantidade);
            }
            else
            {
                await _produtoAppService.DebitarEstoque(id, quantidade);
            }

            return View("Index", await _produtoAppService.ObterTodos());
        }

        private async Task<ProdutoViewModel> PopularCategorias(ProdutoViewModel produto)
        {
            produto.Categorias = await _produtoAppService.ObterCategorias();
            return produto;
        }
    }
}
